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
			this.labelInstancesLazy = new System.Windows.Forms.Label();
			this.labelInstancesSimple = new System.Windows.Forms.Label();
			this.buttonSingletonLazyThread = new System.Windows.Forms.Button();
			this.labelInLazyNombre = new System.Windows.Forms.Label();
			this.labelLazyNombre = new System.Windows.Forms.Label();
			this.buttonSingletonLazy = new System.Windows.Forms.Button();
			this.buttonSingletonSimpleThread = new System.Windows.Forms.Button();
			this.labelNombreSingleton = new System.Windows.Forms.Label();
			this.labelNombre = new System.Windows.Forms.Label();
			this.buttonSimple = new System.Windows.Forms.Button();
			this.groupBoxDependance = new System.Windows.Forms.GroupBox();
			this.listBoxInjection = new System.Windows.Forms.ListBox();
			this.groupBoxSingleton.SuspendLayout();
			this.groupBoxDependance.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxSingleton
			// 
			this.groupBoxSingleton.Controls.Add(this.labelInstancesLazy);
			this.groupBoxSingleton.Controls.Add(this.labelInstancesSimple);
			this.groupBoxSingleton.Controls.Add(this.buttonSingletonLazyThread);
			this.groupBoxSingleton.Controls.Add(this.labelInLazyNombre);
			this.groupBoxSingleton.Controls.Add(this.labelLazyNombre);
			this.groupBoxSingleton.Controls.Add(this.buttonSingletonLazy);
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
			// labelInstancesLazy
			// 
			this.labelInstancesLazy.AutoSize = true;
			this.labelInstancesLazy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInstancesLazy.Location = new System.Drawing.Point(113, 335);
			this.labelInstancesLazy.Name = "labelInstancesLazy";
			this.labelInstancesLazy.Size = new System.Drawing.Size(46, 20);
			this.labelInstancesLazy.TabIndex = 9;
			this.labelInstancesLazy.Text = "Rien";
			// 
			// labelInstancesSimple
			// 
			this.labelInstancesSimple.AutoSize = true;
			this.labelInstancesSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInstancesSimple.Location = new System.Drawing.Point(107, 132);
			this.labelInstancesSimple.Name = "labelInstancesSimple";
			this.labelInstancesSimple.Size = new System.Drawing.Size(46, 20);
			this.labelInstancesSimple.TabIndex = 8;
			this.labelInstancesSimple.Text = "Rien";
			// 
			// buttonSingletonLazyThread
			// 
			this.buttonSingletonLazyThread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSingletonLazyThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSingletonLazyThread.Location = new System.Drawing.Point(12, 321);
			this.buttonSingletonLazyThread.Name = "buttonSingletonLazyThread";
			this.buttonSingletonLazyThread.Size = new System.Drawing.Size(75, 50);
			this.buttonSingletonLazyThread.TabIndex = 7;
			this.buttonSingletonLazyThread.Text = "Lazy Thread";
			this.buttonSingletonLazyThread.UseVisualStyleBackColor = true;
			this.buttonSingletonLazyThread.Click += new System.EventHandler(this.buttonSingletonLazyThread_Click);
			// 
			// labelInLazyNombre
			// 
			this.labelInLazyNombre.AutoSize = true;
			this.labelInLazyNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInLazyNombre.Location = new System.Drawing.Point(113, 261);
			this.labelInLazyNombre.Name = "labelInLazyNombre";
			this.labelInLazyNombre.Size = new System.Drawing.Size(46, 20);
			this.labelInLazyNombre.TabIndex = 6;
			this.labelInLazyNombre.Text = "Rien";
			// 
			// labelLazyNombre
			// 
			this.labelLazyNombre.AutoSize = true;
			this.labelLazyNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLazyNombre.Location = new System.Drawing.Point(113, 231);
			this.labelLazyNombre.Name = "labelLazyNombre";
			this.labelLazyNombre.Size = new System.Drawing.Size(46, 20);
			this.labelLazyNombre.TabIndex = 5;
			this.labelLazyNombre.Text = "Rien";
			// 
			// buttonSingletonLazy
			// 
			this.buttonSingletonLazy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSingletonLazy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSingletonLazy.Location = new System.Drawing.Point(12, 231);
			this.buttonSingletonLazy.Name = "buttonSingletonLazy";
			this.buttonSingletonLazy.Size = new System.Drawing.Size(75, 50);
			this.buttonSingletonLazy.TabIndex = 4;
			this.buttonSingletonLazy.Text = "Lazy";
			this.buttonSingletonLazy.UseVisualStyleBackColor = true;
			this.buttonSingletonLazy.Click += new System.EventHandler(this.buttonSingletonLazy_Click);
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
			// groupBoxDependance
			// 
			this.groupBoxDependance.Controls.Add(this.listBoxInjection);
			this.groupBoxDependance.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBoxDependance.Location = new System.Drawing.Point(334, 0);
			this.groupBoxDependance.Name = "groupBoxDependance";
			this.groupBoxDependance.Size = new System.Drawing.Size(300, 450);
			this.groupBoxDependance.TabIndex = 1;
			this.groupBoxDependance.TabStop = false;
			this.groupBoxDependance.Text = "Injection de dépendance";
			// 
			// listBoxInjection
			// 
			this.listBoxInjection.FormattingEnabled = true;
			this.listBoxInjection.Location = new System.Drawing.Point(6, 28);
			this.listBoxInjection.Name = "listBoxInjection";
			this.listBoxInjection.Size = new System.Drawing.Size(288, 160);
			this.listBoxInjection.TabIndex = 0;
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
			this.groupBoxDependance.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxSingleton;
		private System.Windows.Forms.Label labelNombreSingleton;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Button buttonSimple;
		private System.Windows.Forms.GroupBox groupBoxDependance;
		private System.Windows.Forms.Button buttonSingletonSimpleThread;
		private System.Windows.Forms.Button buttonSingletonLazyThread;
		private System.Windows.Forms.Label labelInLazyNombre;
		private System.Windows.Forms.Label labelLazyNombre;
		private System.Windows.Forms.Button buttonSingletonLazy;
		private System.Windows.Forms.Label labelInstancesLazy;
		private System.Windows.Forms.Label labelInstancesSimple;
		private System.Windows.Forms.ListBox listBoxInjection;
	}
}

