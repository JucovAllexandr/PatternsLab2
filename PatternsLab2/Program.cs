using System;

namespace PatternsLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            WidgetStyleFactory widgetStyleFactory = new WidgetStyleFactory();
            Window mainWindow = new Window("Main", 100,100,800,600);
            Button button = new Button("Button1", 50,50,20,20);
            CheckBox checkBox = new CheckBox("CheckBox1",0,0,40,20);
            CompositeWidgets win1 = new CompositeWidgets();
            win1.AddWidget(mainWindow);
            win1.AddWidget(button);
            win1.AddWidget(checkBox);
            
            win1.Draw(widgetStyleFactory.GetWidgetStyle("kde"));

            MoveHistory history = new MoveHistory();
            foreach (Widget w in win1)
            {
                history.History.Enqueue(w.SaveState());
            }
            win1.Move(10,10);
            
            JSONExportVisitor exportVisitor = new JSONExportVisitor();
            
            foreach (Widget w in win1)
            {
                w.Accept(exportVisitor);
            }
            
            foreach (Widget w in win1)
            {
                w.RestoreState(history.History.Dequeue());
            }
            
            win1.Draw(widgetStyleFactory.GetWidgetStyle("kde"));
        }
    }
}