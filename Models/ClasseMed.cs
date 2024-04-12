using System;
using System.Collections.Generic;

namespace APIsaude.Models;

public partial class ClasseMed
{
    public int CodClass { get; set; }

    public string NomeClasse { get; set; } = null!;

    public virtual ICollection<MatMed> MatMeds { get; } = new List<MatMed>();
}
