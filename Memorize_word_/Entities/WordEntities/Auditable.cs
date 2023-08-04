using Memorize_word_.Healpers;
using System;

namespace Memorize_word_.Entities.WordEntities;

public abstract class Auditable : BaseEntities
{
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Auditable() 
    {
        CreatedAt = TimeHealpers.GetDateTime();
        UpdatedAt = TimeHealpers.GetDateTime();
    }
}
