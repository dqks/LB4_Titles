﻿using System;
using System.Collections.Generic;

namespace LB4_AnimeTitlesApp.Models;

public partial class AnimeType
{
    public short Id { get; set; }

    public string AnimeOfTypes { get; set; } = null!;

    //навигационное свойство
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
