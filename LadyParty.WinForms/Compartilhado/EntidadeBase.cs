﻿namespace LadyParty.WinForms.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public int id;

        public abstract string[] Validar();

        public abstract void AtualizarInformacoes(T entidade);
    }
}
