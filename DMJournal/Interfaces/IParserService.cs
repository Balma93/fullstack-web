
using DMJournal.Models.Dtos;

namespace DMJournal.Interfaces;

public interface IParserService
{
    ParsedMonsterDto? ParseMonster(string mdMessage);
}