﻿using System;

namespace Delta.CapiNet.Asn1
{
    public class Asn1Sequence : Asn1StructuredObject
    {
        internal Asn1Sequence(Asn1Document document, TaggedObject content, Asn1Object parentObject)
            : base(document, content, parentObject) { }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Sequence: {0} child nodes", base.Nodes.Length);
        }
    }
}
