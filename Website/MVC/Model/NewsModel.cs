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

using System;
using Website.MVC.Model.Base;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    public class NewsModel : BasePageModel, IDate, IContentText
    {
        #region IDate Members

        public virtual DateTime Date { get; set; }

        #endregion

        public virtual string ContentText { get; set; }
    }
}