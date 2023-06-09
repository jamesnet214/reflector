﻿using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflector.Data.Models
{
    public class TypeDetails
    {
        public Type Type { get; set; }
        public string Namespace { get; set; }
        public string TypeName { get; set; }
        public bool IsClass { get; set; }
        public bool IsPublic { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsSealed { get; set; }
        public bool IsInterface { get; set; }
        public bool IsEnum { get; set; }
        public bool IsObject { get; set; }
        public Type? BaseType { get; set; }
        public List<MethodInfo> Methods { get; set; }
        public List<PropertyInfo> Properties { get; set; }
        public List<FieldInfo> Fields { get; set; }
    }
}
