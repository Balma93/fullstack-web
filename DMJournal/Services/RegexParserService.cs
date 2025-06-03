
using System.Text.RegularExpressions;
using DMJournal.Interfaces;
using DMJournal.Models.Dtos;

namespace DMJournal.Services;

public class RegexParserService : IParserService
{

    // !!Monster[Name: "Nombre completo", HP: "7", AC: "7"]
    private static readonly Regex MonsterRegex = new Regex(@"!!Monster\[Name:\s*(?<Name>[^,]+),\s*HP:\s*(?<HP>[^,]+),\s*AC:\s*(?<AC>[^,]+)\]", RegexOptions.Compiled);

    public ParsedMonsterDto? ParseMonster(string mdMessage)
    {
        Match match = MonsterRegex.Match(mdMessage);

        if (match.Success)
        {
            return new ParsedMonsterDto
            {
                Name = match.Groups["Name"].Value.Trim(),
                HP = int.Parse(match.Groups["HP"].Value.Trim()),
                AC = int.Parse(match.Groups["AC"].Value.Trim())
            };
        }

        return null;
    }
}