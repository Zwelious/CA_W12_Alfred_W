namespace CA_W12_ALFRED_W
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Players = new System.Windows.Forms.DataGridView();
            this.dgv_Manager = new System.Windows.Forms.DataGridView();
            this.lbl_add = new System.Windows.Forms.Label();
            this.lbl_del = new System.Windows.Forms.Label();
            this.lbl_editmanager = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pos = new System.Windows.Forms.Label();
            this.lbl_teamnum = new System.Windows.Forms.Label();
            this.lbl_nationality = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.teamNum = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.cmb_Nationality = new System.Windows.Forms.ComboBox();
            this.cmb_Team = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_playerid = new System.Windows.Forms.Label();
            this.playerID = new System.Windows.Forms.TextBox();
            this.cmb_chooseTeam = new System.Windows.Forms.ComboBox();
            this.lbl_chooseteam = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.lbl_idplayer = new System.Windows.Forms.Label();
            this.lbl_chosenPlayer = new System.Windows.Forms.Label();
            this.cmb_mTeam = new System.Windows.Forms.ComboBox();
            this.lbl_mteam = new System.Windows.Forms.Label();
            this.lbl_nwManager = new System.Windows.Forms.Label();
            this.dgv_nwManager = new System.Windows.Forms.DataGridView();
            this.lbl_mData = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_cManager = new System.Windows.Forms.Label();
            this.chosenManager = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Players)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nwManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Players
            // 
            this.dgv_Players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Players.Location = new System.Drawing.Point(316, 53);
            this.dgv_Players.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Players.Name = "dgv_Players";
            this.dgv_Players.RowHeadersWidth = 51;
            this.dgv_Players.Size = new System.Drawing.Size(320, 448);
            this.dgv_Players.TabIndex = 0;
            this.dgv_Players.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Players_CellClick);
            // 
            // dgv_Manager
            // 
            this.dgv_Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Manager.Location = new System.Drawing.Point(904, 55);
            this.dgv_Manager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Manager.Name = "dgv_Manager";
            this.dgv_Manager.RowHeadersWidth = 51;
            this.dgv_Manager.Size = new System.Drawing.Size(320, 220);
            this.dgv_Manager.TabIndex = 1;
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add.Location = new System.Drawing.Point(33, 31);
            this.lbl_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(87, 17);
            this.lbl_add.TabIndex = 2;
            this.lbl_add.Text = "Add Player";
            // 
            // lbl_del
            // 
            this.lbl_del.AutoSize = true;
            this.lbl_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_del.Location = new System.Drawing.Point(33, 385);
            this.lbl_del.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_del.Name = "lbl_del";
            this.lbl_del.Size = new System.Drawing.Size(106, 17);
            this.lbl_del.TabIndex = 3;
            this.lbl_del.Text = "Delete Player";
            // 
            // lbl_editmanager
            // 
            this.lbl_editmanager.AutoSize = true;
            this.lbl_editmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editmanager.Location = new System.Drawing.Point(648, 31);
            this.lbl_editmanager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_editmanager.Name = "lbl_editmanager";
            this.lbl_editmanager.Size = new System.Drawing.Size(104, 17);
            this.lbl_editmanager.TabIndex = 4;
            this.lbl_editmanager.Text = "Edit Manager";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(33, 91);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 16);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_pos
            // 
            this.lbl_pos.AutoSize = true;
            this.lbl_pos.Location = new System.Drawing.Point(33, 186);
            this.lbl_pos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pos.Name = "lbl_pos";
            this.lbl_pos.Size = new System.Drawing.Size(55, 16);
            this.lbl_pos.TabIndex = 6;
            this.lbl_pos.Text = "Position";
            // 
            // lbl_teamnum
            // 
            this.lbl_teamnum.AutoSize = true;
            this.lbl_teamnum.Location = new System.Drawing.Point(33, 121);
            this.lbl_teamnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_teamnum.Name = "lbl_teamnum";
            this.lbl_teamnum.Size = new System.Drawing.Size(64, 16);
            this.lbl_teamnum.TabIndex = 6;
            this.lbl_teamnum.Text = "Team no:";
            // 
            // lbl_nationality
            // 
            this.lbl_nationality.AutoSize = true;
            this.lbl_nationality.Location = new System.Drawing.Point(33, 153);
            this.lbl_nationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nationality.Name = "lbl_nationality";
            this.lbl_nationality.Size = new System.Drawing.Size(73, 16);
            this.lbl_nationality.TabIndex = 7;
            this.lbl_nationality.Text = "Nationality:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(33, 222);
            this.lbl_height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(46, 16);
            this.lbl_height.TabIndex = 8;
            this.lbl_height.Text = "Height";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(33, 255);
            this.lbl_weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(49, 16);
            this.lbl_weight.TabIndex = 9;
            this.lbl_weight.Text = "Weight";
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.Location = new System.Drawing.Point(33, 286);
            this.lbl_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(60, 16);
            this.lbl_birth.TabIndex = 10;
            this.lbl_birth.Text = "Birthdate";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(33, 318);
            this.lbl_team.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(83, 16);
            this.lbl_team.TabIndex = 11;
            this.lbl_team.Text = "Team name:";
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(116, 87);
            this.playerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(132, 22);
            this.playerName.TabIndex = 12;
            // 
            // teamNum
            // 
            this.teamNum.Location = new System.Drawing.Point(116, 117);
            this.teamNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamNum.Name = "teamNum";
            this.teamNum.Size = new System.Drawing.Size(132, 22);
            this.teamNum.TabIndex = 13;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(116, 182);
            this.position.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(132, 22);
            this.position.TabIndex = 14;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(116, 218);
            this.height.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(132, 22);
            this.height.TabIndex = 15;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(116, 251);
            this.weight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(132, 22);
            this.weight.TabIndex = 16;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(116, 283);
            this.birthdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(177, 22);
            this.birthdate.TabIndex = 17;
            // 
            // cmb_Nationality
            // 
            this.cmb_Nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nationality.FormattingEnabled = true;
            this.cmb_Nationality.Location = new System.Drawing.Point(116, 149);
            this.cmb_Nationality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Nationality.Name = "cmb_Nationality";
            this.cmb_Nationality.Size = new System.Drawing.Size(160, 24);
            this.cmb_Nationality.TabIndex = 18;
            // 
            // cmb_Team
            // 
            this.cmb_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Team.FormattingEnabled = true;
            this.cmb_Team.Location = new System.Drawing.Point(116, 314);
            this.cmb_Team.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Team.Name = "cmb_Team";
            this.cmb_Team.Size = new System.Drawing.Size(160, 24);
            this.cmb_Team.TabIndex = 19;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(37, 347);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 28);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_playerid
            // 
            this.lbl_playerid.AutoSize = true;
            this.lbl_playerid.Location = new System.Drawing.Point(33, 59);
            this.lbl_playerid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_playerid.Name = "lbl_playerid";
            this.lbl_playerid.Size = new System.Drawing.Size(65, 16);
            this.lbl_playerid.TabIndex = 21;
            this.lbl_playerid.Text = "Player ID:";
            // 
            // playerID
            // 
            this.playerID.Location = new System.Drawing.Point(116, 55);
            this.playerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerID.Name = "playerID";
            this.playerID.Size = new System.Drawing.Size(132, 22);
            this.playerID.TabIndex = 22;
            // 
            // cmb_chooseTeam
            // 
            this.cmb_chooseTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chooseTeam.FormattingEnabled = true;
            this.cmb_chooseTeam.Location = new System.Drawing.Point(116, 405);
            this.cmb_chooseTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_chooseTeam.Name = "cmb_chooseTeam";
            this.cmb_chooseTeam.Size = new System.Drawing.Size(160, 24);
            this.cmb_chooseTeam.TabIndex = 23;
            this.cmb_chooseTeam.SelectionChangeCommitted += new System.EventHandler(this.cmb_chooseTeam_SelectionChangeCommitted);
            // 
            // lbl_chooseteam
            // 
            this.lbl_chooseteam.AutoSize = true;
            this.lbl_chooseteam.Location = new System.Drawing.Point(33, 409);
            this.lbl_chooseteam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_chooseteam.Name = "lbl_chooseteam";
            this.lbl_chooseteam.Size = new System.Drawing.Size(46, 16);
            this.lbl_chooseteam.TabIndex = 24;
            this.lbl_chooseteam.Text = "Team:";
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(37, 473);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(100, 28);
            this.btn_Del.TabIndex = 25;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // lbl_idplayer
            // 
            this.lbl_idplayer.AutoSize = true;
            this.lbl_idplayer.Location = new System.Drawing.Point(33, 439);
            this.lbl_idplayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idplayer.Name = "lbl_idplayer";
            this.lbl_idplayer.Size = new System.Drawing.Size(65, 16);
            this.lbl_idplayer.TabIndex = 26;
            this.lbl_idplayer.Text = "Player ID:";
            // 
            // lbl_chosenPlayer
            // 
            this.lbl_chosenPlayer.AutoSize = true;
            this.lbl_chosenPlayer.Location = new System.Drawing.Point(112, 439);
            this.lbl_chosenPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_chosenPlayer.Name = "lbl_chosenPlayer";
            this.lbl_chosenPlayer.Size = new System.Drawing.Size(0, 16);
            this.lbl_chosenPlayer.TabIndex = 27;
            // 
            // cmb_mTeam
            // 
            this.cmb_mTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mTeam.FormattingEnabled = true;
            this.cmb_mTeam.Location = new System.Drawing.Point(717, 55);
            this.cmb_mTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_mTeam.Name = "cmb_mTeam";
            this.cmb_mTeam.Size = new System.Drawing.Size(160, 24);
            this.cmb_mTeam.TabIndex = 28;
            this.cmb_mTeam.SelectionChangeCommitted += new System.EventHandler(this.cmb_mTeam_SelectionChangeCommitted);
            // 
            // lbl_mteam
            // 
            this.lbl_mteam.AutoSize = true;
            this.lbl_mteam.Location = new System.Drawing.Point(648, 64);
            this.lbl_mteam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mteam.Name = "lbl_mteam";
            this.lbl_mteam.Size = new System.Drawing.Size(46, 16);
            this.lbl_mteam.TabIndex = 29;
            this.lbl_mteam.Text = "Team:";
            // 
            // lbl_nwManager
            // 
            this.lbl_nwManager.AutoSize = true;
            this.lbl_nwManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nwManager.Location = new System.Drawing.Point(648, 283);
            this.lbl_nwManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nwManager.Name = "lbl_nwManager";
            this.lbl_nwManager.Size = new System.Drawing.Size(174, 17);
            this.lbl_nwManager.TabIndex = 30;
            this.lbl_nwManager.Text = "Non-working managers";
            // 
            // dgv_nwManager
            // 
            this.dgv_nwManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nwManager.Location = new System.Drawing.Point(652, 303);
            this.dgv_nwManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_nwManager.Name = "dgv_nwManager";
            this.dgv_nwManager.RowHeadersWidth = 51;
            this.dgv_nwManager.Size = new System.Drawing.Size(423, 198);
            this.dgv_nwManager.TabIndex = 31;
            this.dgv_nwManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nwManager_CellClick);
            // 
            // lbl_mData
            // 
            this.lbl_mData.AutoSize = true;
            this.lbl_mData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mData.Location = new System.Drawing.Point(901, 31);
            this.lbl_mData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mData.Name = "lbl_mData";
            this.lbl_mData.Size = new System.Drawing.Size(174, 17);
            this.lbl_mData.TabIndex = 32;
            this.lbl_mData.Text = "Working Manager Data";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1083, 360);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(128, 28);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "Update Manager";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_cManager
            // 
            this.lbl_cManager.AutoSize = true;
            this.lbl_cManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cManager.Location = new System.Drawing.Point(1083, 303);
            this.lbl_cManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cManager.Name = "lbl_cManager";
            this.lbl_cManager.Size = new System.Drawing.Size(135, 17);
            this.lbl_cManager.TabIndex = 34;
            this.lbl_cManager.Text = "Chosen Manager:";
            // 
            // chosenManager
            // 
            this.chosenManager.AutoSize = true;
            this.chosenManager.Location = new System.Drawing.Point(1083, 332);
            this.chosenManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chosenManager.Name = "chosenManager";
            this.chosenManager.Size = new System.Drawing.Size(0, 16);
            this.chosenManager.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 554);
            this.Controls.Add(this.chosenManager);
            this.Controls.Add(this.lbl_cManager);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_mData);
            this.Controls.Add(this.dgv_nwManager);
            this.Controls.Add(this.lbl_nwManager);
            this.Controls.Add(this.lbl_mteam);
            this.Controls.Add(this.cmb_mTeam);
            this.Controls.Add(this.lbl_chosenPlayer);
            this.Controls.Add(this.lbl_idplayer);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.lbl_chooseteam);
            this.Controls.Add(this.cmb_chooseTeam);
            this.Controls.Add(this.playerID);
            this.Controls.Add(this.lbl_playerid);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_Team);
            this.Controls.Add(this.cmb_Nationality);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.position);
            this.Controls.Add(this.teamNum);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_nationality);
            this.Controls.Add(this.lbl_teamnum);
            this.Controls.Add(this.lbl_pos);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_editmanager);
            this.Controls.Add(this.lbl_del);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.dgv_Manager);
            this.Controls.Add(this.dgv_Players);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Players)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nwManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Players;
        private System.Windows.Forms.DataGridView dgv_Manager;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Label lbl_del;
        private System.Windows.Forms.Label lbl_editmanager;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pos;
        private System.Windows.Forms.Label lbl_teamnum;
        private System.Windows.Forms.Label lbl_nationality;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.TextBox teamNum;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.ComboBox cmb_Nationality;
        private System.Windows.Forms.ComboBox cmb_Team;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_playerid;
        private System.Windows.Forms.TextBox playerID;
        private System.Windows.Forms.ComboBox cmb_chooseTeam;
        private System.Windows.Forms.Label lbl_chooseteam;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label lbl_idplayer;
        private System.Windows.Forms.Label lbl_chosenPlayer;
        private System.Windows.Forms.ComboBox cmb_mTeam;
        private System.Windows.Forms.Label lbl_mteam;
        private System.Windows.Forms.Label lbl_nwManager;
        private System.Windows.Forms.DataGridView dgv_nwManager;
        private System.Windows.Forms.Label lbl_mData;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_cManager;
        private System.Windows.Forms.Label chosenManager;
    }
}

