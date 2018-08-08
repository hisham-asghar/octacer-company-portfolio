using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models.ViewModels
{
    public class ServiceViewModel
    {
        public string HeaderImage { get; set; }
        public string HeaderTitle { get; set; }
        public string PageTitle { get; set; }
        public string Tagline { get; set; }
        public List<ServicePanelViewModel> Panels { get; set; }
        public List<FeatureItemViewModel> FeatureItems { get; set; }
        public string HeaderButtonText { get; set; }
        public string HeaderButtonLink { get; set; }
    }
    public class FeatureItemViewModel
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
    public class ServicePanelViewModel
    {
        public string ImagePath { get; set; }
        public ServicePanelType PanelType { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
    public enum ServicePanelType
    {
        LeftTextRightImage,
        RightTextLeftImage
    }
    public class ServiceViewConstants
    {
        public const string UiUxDesign = "ui-ux-design";
        public const string WebDev = "web-development-services";
    }
}