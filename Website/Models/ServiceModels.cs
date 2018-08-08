using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Models.ViewModels;

namespace Website.Models
{
    public class ServiceModels
    {
        public static ViewModels.ServiceViewModel GetUiUxDesignViewModel()
        {
            var model = new ViewModels.ServiceViewModel()
            {
                HeaderImage = "//www.iqvis.com/wp-content/uploads/2017/08/ui-development.jpg",
                HeaderTitle = "BUILDING INTUITIVE UI DESIGNS FOR YOUR PRODUCTS & APPS",
                HeaderButtonText = "Contact Now",
                HeaderButtonLink = "/Home/Contact",
                PageTitle = "UI Development as Per Your Needs",
                Tagline = "We take pride in offering a bunch of innovative user interface designing services that not only incorporate the latest technologies but also comply with user experience practices. We don’t design apps but a unique user experience.",
                FeatureItems = new List<FeatureItemViewModel>(),
                Panels = new List<ServicePanelViewModel>()
                {
                    new ServicePanelViewModel()
                    {
                        PanelType = ServicePanelType.LeftTextRightImage,
                        Title = "UNIQUE UI FOR EVERY ENGAGEMENT",
                        Text = "We believe that every engagement is unique. Hence, our best UI designers provide totally unique and user-centric interface designs. Be it an app, product, web app, or some branding element, offering the best end-user experience is imperative. Having read the best practices of user experience management and user-centric design, our team of expert designers offers the best and unique engagement models.",
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/creativity-and-design-icon-1.png"
                    },
                    new ServicePanelViewModel()
                    {
                        PanelType = ServicePanelType.RightTextLeftImage,
                        Title = "DESIGN WITH FOCUS ON YOUR USERS",
                        Text = "Being of the leading Design and Development Company, IQVIS has set the best SOP for service delivery. We incorporate the practices of user experience designs that include development activities at every stage of the lifecycle of your product and apps. Needs of the end-users are a central part of the product design process and our UX/UI experts work with the right focus on the same.",
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/ux-design-with-focus-on-your-users.jpg"
                    },
                    new ServicePanelViewModel()
                    {
                        PanelType = ServicePanelType.LeftTextRightImage,
                        Title = "MAXIMIZE YOUR ROI",
                        Text = "Our UI design services help our clients offer a robust and scalable user experience, which let them maximize their ROI and achieve core business goals. Our competitive edge lies in the blending latest technologies with your branding needs, user experiences, and market needs. We ensure that you receive high ROI on every dollar you invest.",
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/ux-maximize-your-rol.jpg"
                    },
                    new ServicePanelViewModel()
                    {
                        PanelType = ServicePanelType.RightTextLeftImage,
                        Title = "OUR PROCESS",
                        Text = "Our design process starts by setting objectives and goals. It sets the foundation for strategy, design, and information architecture. From information architecture, we move to wire-framing and technology selection. Once that part is done then comes user testing and UI development, which is finally integrated into the development. At every stage, we keep the clients informed and seek their approval at every stage.",
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/ux-our-process.jpg"
                    }
                }
            };
            return model;
        }

        public static ViewModels.ServiceViewModel GetWebDevViewModel()
        {
            var model = new ViewModels.ServiceViewModel()
            {
                HeaderImage = "https://www.iqvis.com/wp-content/uploads/2017/08/bg-web-development.jpg",
                HeaderTitle = "HIRE THE TEAM OF EXPERT WEB DEVELOPERS AND DESIGNERS",
                HeaderButtonText = "Hire Today",
                HeaderButtonLink = "/Home/Contact",
                PageTitle = "We Create Experience Not Just Apps",
                Tagline = "Delivering high performance, secure, customized and seamlessly integrated websites, web apps, portals, and web applications as per your requirements. We are experts in mature and emerging web technologies.",
                FeatureItems = new List<FeatureItemViewModel>()
                {
                    new FeatureItemViewModel()
                    {
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/ux-inactive.png",
                        Title = "UI DEVELOPMENT",
                        Text = "We offer UI development for websites, apps, and portals. Using deep expertise in design, we serve your purpose by crafting a unique user experience and interface design."
                    },

                    new FeatureItemViewModel()
                    {
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/mobile-friendly-inactive-2.png",
                        Title = "RESPONSIVE WEBSITES",
                        Text = "We offer mobile-friendly web development services using agile and lean practices that lead to optimum.Our designed websites are responsive for most used devices."
                    },

                    new FeatureItemViewModel()
                    {
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/unique-qa-inactive-1.png",
                        Title = "WEB APPS",
                        Text = "Whether you’re planning a SaaS product, e-commerce website, collaboration portal, or some custom web application, our team can deliver on as per your requirements."
                    }
                },
                Panels = new List<ServicePanelViewModel>()
                {
                    new ServicePanelViewModel()
                    {
                        PanelType = ServicePanelType.RightTextLeftImage,
                        Text = "We make beautiful and stunning websites, portals and web apps with high levels of functionality and awesomeness in sight. To help you realize your most ambitious and complex projects, we strive to help you from one end to the other. From conception and strategy to implementation, IQVIS builds premium web solutions for businesses, individuals, associations, non-profits, governments, and Fortune 500 companies.",
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/websites-and-web-apps.png"
                    },
                    new ServicePanelViewModel()
                    {
                        PanelType = ServicePanelType.LeftTextRightImage,
                        Text = "Driven by passion and innovation, we deliver top notch custom web development services to our clients, ranging from startups to enterprises. While developing websites, we keep your industry, requirements, aesthetics, UX, and search engine optimization in sight. Our websites are well-optimized for multiple screens (large or small) and are built to rank on Google search engine results.",
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/web-design-and-development.png"
                    },
                    new ServicePanelViewModel()
                    {
                        PanelType = ServicePanelType.RightTextLeftImage,
                        Text = "Owing to rapid mobile adoption and Google’s Mobilegeddon (The mobile responsiveness update), we ensure that our clients receive a responsive and mobile-friendly website. The same goes for web apps and SaaS products, if their target is mobile visitor, we ensure that they are easily accessible via small screens.",
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/mobile-responsiveness-update.png"
                    },
                    new ServicePanelViewModel()
                    {
                        PanelType = ServicePanelType.LeftTextRightImage,
                        Text = "Just let us know which particular device/devices you are aiming your app for – desktop, iPhone, iPad, Tablets, and android smartphones and our solutions architects will ensure your app’s compatibility with those screens and systems. We design websites based upon the latest W3C compliance principles.",
                        ImagePath = "https://www.iqvis.com/wp-content/uploads/2017/08/web-presences.png"
                    }
                }
            };
            return model;
        }
    }
}