﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DndCharGen.Workflow.PromptedTasks.Tasks
{
    /// <summary>
    /// Interaction logic for WeaponProficiencySelector.xaml
    /// </summary>
    public partial class WeaponProficiencySelector : Window, IPromptedTask
    {
        public WeaponProficiencySelector()
        {
            InitializeComponent();
        }

        public Dictionary<string, object> Parameters => throw new NotImplementedException();

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
