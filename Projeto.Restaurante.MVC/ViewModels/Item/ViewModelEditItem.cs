﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Projeto.Restaurante.MVC.ViewModels.Opcao;
using Projeto.Restaurante.MVC.ViewModels.Pedido;
using Projeto.Restaurante.MVC.ViewModels.Prato;

namespace Projeto.Restaurante.MVC.ViewModels.Item
{
    public class ViewModelEditItem
    {
        #region Propriedades
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório!", AllowEmptyStrings = false)]
        public int PedidoId { get; set; }

        [DisplayName("Pedido")]
        public ViewModelDetailsPedido Pedido { get; set; }

        [Required(ErrorMessage = "Obrigatório!", AllowEmptyStrings = false)]
        public int PratoId { get; set; }

        [DisplayName("Prato")]
        public ViewModelDetailsPrato Prato { get; set; }

        [DisplayName("Opções")]
        public IEnumerable<ViewModelDetailsOpcao> Opcoes { get; set; }

        public bool Ativo { get; set; }
        #endregion
    }
}