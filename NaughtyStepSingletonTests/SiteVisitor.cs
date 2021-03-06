﻿// ****************************************************************
// Copyright 2014, Mark Dickinson
// This is free software licensed under the MIT license. You may
// obtain a copy of the license at http://naughtystepbdd.org
// ****************************************************************

using NaughtyStep;
using Should;

namespace NaughtyStepSingletonTests
{
    [ContextSessionLifestyle(Lifestyle = SessionLifestyle.Singleton)]
    [BrowserSettings(Browser = BrowserType.Firefox)]
    public class SiteVisitor : NaughtyStepCoypuContext
    {
        public void VisitHomePage()
        {
            Browser.Visit("http://www.naughtystepbdd.org/index.html");
            Browser.Location.AbsoluteUri.ShouldEqual("http://www.naughtystepbdd.org/index.html");
        }

        public void DocumentationLinkExists()
        {
            Browser.FindLink("Documentation").Exists().ShouldBeTrue();
        }

        public void ClickDocumentationLink()
        {
            Browser.FindLink("Documentation").Click();
        }

        public void UserShouldBeAtDocumentationPage()
        {
            Browser.Location.AbsoluteUri.ShouldEqual("http://www.naughtystepbdd.org/Documentation.htm");
        }

    }
}