using System;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TailwindPOS
{

   [Observable]
   internal partial class frmCustAdd
      : Mobilize.Web.Form
   {

      [Intercepted]

      bool m_savedCustomer { get; set; } = false;

      [Intercepted]
      int m_savedCustomerID { get; set; } = 0;


      public frmCustAdd()
      	: base()
      {
      	if (m_vb6FormDefInstance == null)
      	{
      		if (m_InitializingDefInstance)
      		{
      			m_vb6FormDefInstance = this;
      		}
      		else
      		{
      			try
      			{
      				//For the start-up form, the first instance created is the default instance.
      				if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
      				{
      					m_vb6FormDefInstance = this;
      				}
      			}
      			catch
      			{
      			}
      		}
      	}
      	//This call is required by the Windows Form Designer.
      	InitializeComponent();
      }

      [Intercepted]



      public bool SavedCustomerID
      {
      	get
      	{
      		int SaveCustomerID = m_savedCustomerID;
      		return false;
      	}
      }

      [Intercepted]


      public bool SavedCustomer
      {
      	get
      	{
      		bool SaveCustomer = m_savedCustomer;
      		return false;
      	}
      }


      private void cbClose_Click(Object eventSender, EventArgs eventArgs)
      {
      	this.Hide();
      }

      private void cbSave_Click(Object eventSender, EventArgs eventArgs)
      {
      	try
      	{
      		m_savedCustomerID = Convert.ToInt32(MainModule.SaveNewCustomer(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtCompany.Text, txtPhone.Text, txtStreetAddress1.Text, txtStreetAddress2.Text, txtState.Text, txtCity.Text, txtZipCode.Text, txtCounty.Text));
      		ClearFields();
      		m_savedCustomer = true;
      		this.Hide();
      	}
      	catch
      	{
      	}

      	m_savedCustomer = false;
      }

      private void ClearFields()
      {
      	txtFirstName.Text = "";
      	txtLastName.Text = "";
      	txtEmail.Text = "";
      	txtCompany.Text = "";
      	txtPhone.Text = "";
      	txtStreetAddress1.Text = "";
      	txtStreetAddress2.Text = "";
      	txtState.Text = "";
      	txtCity.Text = "";
      	txtZipCode.Text = "";
      	txtCounty.Text = "";
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }
}