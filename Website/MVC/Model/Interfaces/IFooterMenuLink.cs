﻿// /*===========================================================
//    Copyright 2013 Robbert Hock
//  
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//  
// ============================================================*/

using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IFooterMenuLink
    {
        [SitecoreField(FieldName = "Link Title")]
        string LinkTitle { get; set; }

        [SitecoreField(FieldName = "Link Url")]
        Link LinkUrl { get; set; }

        [SitecoreField(FieldName = "Link CssClass")]
        string LinkCssClass { get; set; }
    }
}