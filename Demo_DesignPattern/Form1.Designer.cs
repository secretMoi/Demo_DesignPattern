namespace Demo_DesignPattern
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxSingleton = new System.Windows.Forms.GroupBox();
			this.groupBoxDependance = new System.Windows.Forms.GroupBox();
			this.buttonSimple = new System.Windows.Forms.Button();
			this.labelNombre = new System.Windows.Forms.Label();
			this.labelNombreSingleton = new System.Windows.Forms.Label();
			this.buttonSingletonSimpleThread = new System.Windows.Forms.Button();
			this.groupBoxSingleton.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxSingleton
			// 
			this.groupBoxSingleton.Controls.Add(this.buttonSingletonSimpleThread);
			this.groupBoxSingleton.Controls.Add(this.labelNombreSingleton);
			this.groupBoxSingleton.Controls.Add(this.labelNombre);
			this.groupBoxSingleton.Controls.Add(this.buttonSimple);
			this.groupBoxSingleton.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBoxSingleton.Location = new System.Drawing.Point(0, 0);
			this.groupBoxSingleton.Name = "groupBoxSingleton";
			this.groupBoxSingleton.Size = new System.Drawing.Size(300, 450);
			this.groupBoxSingleton.TabIndex = 0;
			this.groupBoxSingleton.TabStop = false;
			this.groupBoxSingleton.Text = "Singleton";
			// 
			// groupBoxDependance
			// 
			this.groupBoxDependance.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBoxDependance.Location = new System.Drawing.Point(334, 0);
			this.groupBoxDependance.Name = "groupBoxDependance";
			this.groupBoxDependance.Size = new System.Drawing.Size(300, 450);
			this.groupBoxDependance.TabIndex = 1;
			this.groupBoxDependance.TabStop = false;
			this.groupBoxDependance.Text = "Injection de dépendance";
			// 
			// buttonSimple
			// 
			this.buttonSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSimple.Location = new System.Drawing.Point(6, 28);
			this.buttonSimple.Name = "buttonSimple";
			this.buttonSimple.Size = new System.Drawing.Size(75, 50);
			this.buttonSimple.TabIndex = 0;
			this.buttonSimple.Text = "Simple";
			this.buttonSimple.UseVisualStyleBackColor = true;
			this.buttonSimple.Click += new System.EventHandler(this.buttonSimple_Click);
			// 
			// labelNombre
			// 
			this.labelNombre.AutoSize = true;
			this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.Location = new System.Drawing.Point(107, 28);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(46, 20);
			this.labelNombre.TabIndex = 1;
			this.labelNombre.Text = "Rien";
			// 
			// labelNombreSingleton
			// 
			this.labelNombreSingleton.AutoSize = true;
			this.labelNombreSingleton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreSingleton.Location = new System.Drawing.Point(107, 58);
			this.labelNombreSingleton.Name = "labelNombreSingleton";
			this.labelNombreSingleton.Size = new System.Drawing.Size(46, 20);
			this.labelNombreSingleton.TabIndex = 2;
			this.labelNombreSingleton.Text = "Rien";
			// 
			// buttonSingletonSimpleThread
			// 
			this.buttonSingletonSimpleThread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSingletonSimpleThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSingletonSimpleThread.Location = new System.Drawing.Point(6, 118);
			this.buttonSingletonSimpleThread.Name = "buttonSingletonSimpleThread";
			this.buttonSingletonSimpleThread.Size = new System.Drawing.Size(75, 50);
			this.buttonSingletonSimpleThread.TabIndex = 3;
			this.buttonSingletonSimpleThread.Text = "Simple Thread";
			this.buttonSingletonSimpleThread.UseVisualStyleBackColor = true;
			this.buttonSingletonSimpleThread.Click += new System.EventHandler(this.buttonSingletonSimpleThread_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 450);
			this.Controls.Add(this.groupBoxDependance);
			this.Controls.Add(this.groupBoxSingleton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBoxSingleton.ResumeLayout(false);
			this.groupBoxSingleton.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxSingleton;
		private System.Windows.Forms.Label labelNombreSingleton;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Button buttonSimple;
		private System.Windows.Forms.GroupBox groupBoxDependance;
		private System.Windows.Forms.Button buttonSingletonSimpleThread;
	}
}

