
using DMJournal.Models.Dtos;

namespace DMJournal.Interfaces;

public interface IRenderService
{
    string RenderMonster(ParsedMonsterDto monster);
}