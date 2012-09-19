﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Net;

namespace Recurly
{
    public class AdjustmentList : RecurlyList<Adjustment>
    {

        internal void ReadXml(XmlTextReader reader)
        {

            while (reader.Read())
            {
                if ( (reader.Name.Equals("adjustments") || reader.Name.Equals("line_items") )
                    && reader.NodeType == XmlNodeType.EndElement)
                    break;

                if (reader.NodeType == XmlNodeType.Element && reader.Name.Equals("adjustment"))
                {
                    this.Add(new Adjustment(reader));
                }
            }

        }
        
    }

}