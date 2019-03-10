namespace PatternsLab2
{
    public interface IVisitor
    {
        void VisitButton(Button button);
        void VisitCheckBox(CheckBox checkBox);
        void VisitWindow(Window window);
    }
}