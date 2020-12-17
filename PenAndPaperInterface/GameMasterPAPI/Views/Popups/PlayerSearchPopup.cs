﻿using GameMasterPAPI.Server;
using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMasterPAPI.Views
{
    public partial class PlayerSearchPopup : PAPIPopup, ITranslatableView
    {
        private uint attemptCounter = 0;
        private const uint MAX_SEARCH_TIME = 3;
        public PlayerSearchPopup()
        {
            InitializeComponent();
            WfLogger.Log(this, LogLevel.DEBUG, "Initialized components");
            addPlayerButton.Visible = false;
            addPlayerButton.Enabled = false;
        }

        public override void SetTextToActiveLanguage()
        {
            if (activeLanguage == GameSettings.GetLanguage())
            {
                return;
            }

            using (ResXResourceSet resSet = new ResXResourceSet(GetResourceFile()))
            {
                Translate(resSet, foundPlayerNameLabel);
                Translate(resSet, cancelButton);
                Translate(resSet, addPlayerButton);
                Translate(resSet, searchPlayerButton);
                foundPlayerNameTextbox.Text = "";
            }
            WfLogger.Log(this, LogLevel.DEBUG, "All text set to " + GameSettings.GetLanguage());
        }

        private void SearchPlayer()
        {
            while (attemptCounter < MAX_SEARCH_TIME)
            { 
                if (PendingMessages.waitingPlayers.Count > 0)
                {
                    WfLogger.Log(this, LogLevel.DEBUG, "Pending Player Requests found: " + PendingMessages.waitingPlayers.Count);
                    this.foundPlayerNameTextbox.Text = PendingMessages.waitingPlayers[0].name;
                    addPlayerButton.Visible = true;
                    addPlayerButton.Enabled = true;
                    searchPlayerButton.Visible = false;
                    return;
                }
                else
                {
                    WfLogger.Log(this, LogLevel.DEBUG, "No Pending Player Requests found... trying again (Attempt number: " + attemptCounter + ")");
                    searchPlayerButton.Visible = false;
                    Thread.Sleep(1000);
                    attemptCounter++;
                    SearchPlayer();
                    searchPlayerButton.Visible = true;
                    return;
                }
            }
        }

        private void AddPlayer(Player player)
        {
            ((GameCreationView)ViewController.gameCreationView).AddPlayer(player);
            PendingMessages.waitingPlayers.RemoveAt(0);
            addPlayerButton.Visible = false;
            addPlayerButton.Enabled = false;
            searchPlayerButton.Visible = true;
        }

        private void searchPlayerButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "search Player Button was clicked, searching for pending player requests...");
            attemptCounter = 0;
            SearchPlayer();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Add Player Button was clicked, adding Player '" + PendingMessages.waitingPlayers[0].name + "' to Game");
            AddPlayer(PendingMessages.waitingPlayers[0]);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            WfLogger.Log(this, LogLevel.DEBUG, "Cancel Button was clicked, Popup closes");
            this.Hide();
        }
    }
}