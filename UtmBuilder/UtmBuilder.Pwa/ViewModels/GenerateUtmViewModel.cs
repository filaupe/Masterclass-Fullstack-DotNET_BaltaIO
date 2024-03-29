﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace UtmBuilder.Pwa.ViewModels
{
    public partial class GenerateUtmViewModel: ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Url))]
        private string _websiteUrl = string.Empty;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Url))]
        private string _id = string.Empty;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Url))]
        private string _source = string.Empty;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Url))]
        private string _medium = string.Empty;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Url))]
        private string _name = string.Empty;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Url))]
        private string _term = string.Empty;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Url))]
        private string _content = string.Empty;

        public string Url
        {
            get
            {
                try 
	            {
                    var utm = new Utm(url:_websiteUrl, id:_id, source:_source, medium:_medium, name:_name, term:_term, content:_content);
                    return utm.ToString();
	            }
	            catch (Exception ex)
	            {
                    return ex.Message;
	            }   
            }
        }
    }
}
