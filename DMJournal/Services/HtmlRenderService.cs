
using System.Text;
using DMJournal.Interfaces;
using DMJournal.Models.Dtos;

namespace DMJournal.Services;

public class HtmlRenderService : IRenderService
{


    public string RenderMonster(ParsedMonsterDto monster)
    {
        if (monster == null) return "<p>Error: Monstruo no encontrado o malformado.</p>";

        var sb = new StringBuilder();
        sb.AppendLine("<div style=\"border: 1px solid black; padding: 10px; margin-bottom: 10px; width: 300px;\">"); // Estilos inline para PoC
        sb.AppendLine($"    <h3>{System.Net.WebUtility.HtmlEncode(monster.Name)}</h3>");
        sb.AppendLine($"    <p><strong>HP:</strong> {System.Net.WebUtility.HtmlEncode(monster.HP.ToString())}</p>");
        sb.AppendLine($"    <p><strong>CA:</strong> {System.Net.WebUtility.HtmlEncode(monster.AC.ToString())}</p>");
        sb.AppendLine("</div>");
        return sb.ToString();
    }

}

