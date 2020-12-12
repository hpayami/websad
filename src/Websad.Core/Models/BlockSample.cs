﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Websad.Core.Enum;

namespace Websad.Core.Models {

    [Table(name: "Block_Samples")]
    public class BlockSample {

        public BlockSample() {

        }

        #region Properties
        public long Id { get; set; }
        public string Title { get; set; }
        public Guid BlockId { get; set; }
        public string Attributes { get; set; }
        public string OutputSrc { get; set; }
        public PostBodyType BodyType { get; set; }
        public bool IsDefault { get; set; }
        public string Description { get; set; }

        #endregion

        #region Navigations
        public Block Block { get; set; }

        #endregion
    }
}
