﻿using LadyParty.WinForms.Compartilhado;

namespace LadyParty.WinForms.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public TipoTemaEnum tipo { get; set; }
        public string temaNome { get; set; }
        public List<ItemTema> listaItens { get; set; }

        public Tema(TipoTemaEnum tipo, string temaNome)
        {
            this.tipo = tipo;
            this.temaNome = temaNome;
            listaItens = new List<ItemTema>();
        }

    }
}
