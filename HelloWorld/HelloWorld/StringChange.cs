using System.Text;

namespace HelloWorld;
internal class StringChange
{
    string text = "{0} estava atoa então ele {1} uma moeda no ar para decidir o que fazer";
    string finalText = "";
    public void ChangeStringText()
    {
        finalText = string.Format(text, "joao", "jogou");
    }
    public string GetText() => finalText;
}
