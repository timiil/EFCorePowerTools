﻿using EFCorePowerTools.Handlers.Compare;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Input;

namespace EFCorePowerTools.ViewModels
{
    public class CompareLogItemViewModel : ObservableObject
    {
        private bool _visible;
        private bool _checked;

        public bool Visible
        {
            get => _visible; set => SetProperty(ref _visible, value);
        }
        public int Level
        {
            get; set;
        }
        public CompareType Type
        {
            get; set;
        }
        public CompareState State
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public CompareAttributes Attribute
        {
            get; set;
        }
        public string Expected
        {
            get; set;
        }
        public string Found
        {
            get; set;
        }
        public bool? HasChildren
        {
            get; set;
        }
        public bool Checked
        {
            get => _checked; set => SetProperty(ref _checked, value);
        }
    }
}
