namespace Stub._UpgradeHelpers
{

   public class DataGridViewFlexEx
      : Stub._System.Windows.Forms.DataGridViewEx
   {

      public bool AllowUserToResizeColumns { get; set; }

      public bool AllowUserToResizeRows { get; set; }

      public Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode
      ColumnHeadersHeightSizeMode { get; set; }

      public bool ReadOnly { get; set; }

      public Stub._UpgradeHelpers.FocusRectSettings FocusRect { get; set; }

      public Mobilize.Web.DataGridViewSelectionMode SelectionMode { get; set; }

   }

}