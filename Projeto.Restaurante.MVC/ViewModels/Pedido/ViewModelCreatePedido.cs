﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Projeto.Restaurante.MVC.ViewModels.Item;
using Projeto.Restaurante.MVC.ViewModels.Mesa;

namespace Projeto.Restaurante.MVC.ViewModels.Pedido
{
    public class ViewModelCreatePedido
    {
        #region Propriedades
        [Required(ErrorMessage = "Obrigatório!", AllowEmptyStrings = false)]
        public int MesaId { get; set; }

        [DisplayName("Mesa")]
        public ViewModelDetailsMesa Mesa { get; set; }

        [DisplayName("Itens")]
        public IEnumerable<ViewModelCreateItem> Itens { get; set; }

        public bool Ativo { get; set; }
        #endregion
    }
}