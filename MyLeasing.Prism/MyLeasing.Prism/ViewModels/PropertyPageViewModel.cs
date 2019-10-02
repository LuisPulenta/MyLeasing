﻿using MyLeasing.Common.Helpers;
using MyLeasing.Common.Models;
using Newtonsoft.Json;
using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyLeasing.Prism.ViewModels
{
    public class PropertyPageViewModel : ViewModelBase
    {
        private PropertyResponse _property;
        private ObservableCollection<RotatorModel> _imageCollection;
        public PropertyPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Details";
            Property = JsonConvert.DeserializeObject<PropertyResponse>(Settings.Property);
            LoadImages();
        }

        public ObservableCollection<RotatorModel> ImageCollection
        {
            get => _imageCollection;
            set => SetProperty(ref _imageCollection, value);
        }

        public PropertyResponse Property
        {
            get => _property;
            set => SetProperty(ref _property, value);
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            //if (parameters.ContainsKey("property"))
            //{
            //    Property = parameters.GetValue<PropertyResponse>("property");
            //    Title = $"Property: {Property.Neighborhood}";
            //    //LoadImages();
            //}
            Property = JsonConvert.DeserializeObject<PropertyResponse>(Settings.Property);
            LoadImages();
        }

        private void LoadImages()
        {
            var list = new List<RotatorModel>();
            foreach (var propertyImage in Property.PropertyImages)
            {
                list.Add(new RotatorModel { Image = propertyImage.ImageUrl });
            }

            ImageCollection = new ObservableCollection<RotatorModel>(list);
        }
    }
}