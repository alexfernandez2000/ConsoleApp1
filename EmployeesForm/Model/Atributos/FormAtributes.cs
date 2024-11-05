using System;

    [AttributeUsage(AttributeTargets.Property)]
    public class FormAtributes : Attribute
    {
        public bool ShowForm { get; }

        public FormAtributes(bool isShowable)
        {
            ShowForm = isShowable;
        }
    }
