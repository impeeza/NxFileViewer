﻿using System.Collections.Generic;

namespace Emignatik.NxFileViewer.NSP.Models
{
    /// <summary>
    /// Model aggregating all useful information contained in a NSP file
    /// </summary>
    public class NspInfo
    {

        /// <summary>
        /// Gets the header of the metadata file (*.cnmt.nca)
        /// </summary>
        public CnmtInfo CnmtInfo { get; set; }

        /// <summary>
        /// Gets the list of files in NSP
        /// </summary>
        public PfsFile[] Files { get; set; }

        /// <summary>
        /// Gets information contained in control.nacp file
        /// Maybe null for add-on
        /// </summary>
        public NacpInfo NacpInfo { get; set; }

        public List<IconInfo> Icons { get; set; }


    }
}