﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryotech_Catalog.Classes;

namespace Cryotech_Catalog
{
    public partial class FridgeTemplate : UserControl
    {
        Fridge NewFridge;

        int HardFeaturesLabelStatus = 0;
        
        public FridgeTemplate(Fridge NewEmptyFridge)
        {
            InitializeComponent();

            NewFridge = NewEmptyFridge;

            TitleLabel.Text = NewFridge.TitleToString("Fridge");
            //TitleLabel.ForeColor = Color.SteelBlue;

            ColorInfoLabel.Text = NewFridge.Color;
            FridgeUsefulVolumeInfoLabel.Text = Convert.ToString(NewFridge.FridgeUsefulVolume) + " L";
            FreezerUsefulVolumeInfoLabel.Text = Convert.ToString(NewFridge.FreezerUsefulVolume) + " L";
            FridgeTypeInfoLabel.Text = Convert.ToString(NewFridge.DeviceType);
            CompressorsAmountInfoLabel.Text = Convert.ToString(NewFridge.CompressorsAmount);
            ControlTypeInfoLabel.Text = Convert.ToString(NewFridge.ControlType);
            DimensionsInfoLabel.Text = NewFridge.DimensionsToString() + " sm";
            WeightInfoLabel.Text = Convert.ToString(NewFridge.Weight) + " kg";
            PriceLabel.Text = Convert.ToString(NewFridge.Price) + " UAH";
            PriceLabel.ForeColor = System.Drawing.Color.Red;

            HardFeaturesInfoLabel.Text = "";
        }

        private void ShowHardFeaturesLabel_Click(object sender, EventArgs e)
        {
            if (HardFeaturesLabelStatus == 0)
            {
                ShowHardFeaturesLabel1.Text = "Hide Hard Features";
                HardFeaturesInfoLabel.Text = NewFridge.HardFeaturesToString();
                HardFeaturesLabelStatus = 1;
            }
            else if(HardFeaturesLabelStatus == 1)
            {
                ShowHardFeaturesLabel1.Text = "Show Hard Features";
                HardFeaturesInfoLabel.Text = "";
                HardFeaturesLabelStatus = 0;
            }
        }

        private void TitleLabel_DoubleClick(object sender, EventArgs e)
        {
            ShowFridgeFullInfo FridgeInfoForm = new ShowFridgeFullInfo(NewFridge);
            FridgeInfoForm.Show();
        }
    }
}