﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FbxSharp
{
    public struct Token
    {
        public Token(TokenType type, string value)
        {
            Type = type;
            Value = value;
        }

        public readonly TokenType Type;
        public readonly string Value;

        public override bool Equals(object obj)
        {
            if (!(obj is Token)) return false;

            var token = (Token)obj;

            return
                token.Type == this.Type &&
                token.Value == this.Value;
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ Value.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} \"{1}\"", Type, Value);
        }
    }
}
