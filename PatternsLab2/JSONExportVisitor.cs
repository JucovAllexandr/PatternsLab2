using System;

namespace PatternsLab2
{
    public class JSONExportVisitor:IVisitor
    {
        public void VisitButton(Button button)
        {
            Console.WriteLine("<type='Button' name='"+button.Name+"'" +
                              " pos='"+button.X+","+button.Y+"'" +
                              "width='"+button.Width+"' height='"+button.Height+"'>");
        }

        public void VisitCheckBox(CheckBox checkBox)
        {
            Console.WriteLine("<type='CheckBox' name='"+checkBox.Name+"'" +
                              " pos='"+checkBox.X+","+checkBox.Y+"'" +
                              "width='"+checkBox.Width+"' height='"+checkBox.Height+"'>");
        }

        public void VisitWindow(Window window)
        {
            Console.WriteLine("<type='Window' name='"+window.Name+"'" +
                              " pos='"+window.X+","+window.Y+"'" +
                              "width='"+window.Width+"' height='"+window.Height+"'>");
        }
    }
}