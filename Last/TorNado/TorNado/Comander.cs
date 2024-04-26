using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorNado
{
    public class Comander
    {
        public System.Byte p_nVirtKey = 65;
        public System.String p_Description = "A";
        public Comander() { }
        public Comander(System.Byte _nVirtKey, System.String _Description) 
        {
            this.p_nVirtKey = _nVirtKey;
            this.p_Description= _Description;
        }
        public Comander Set(
            Comander _this = null
            , System.Nullable<System.Byte> _nVirtKey = null
            , System.String _Description = null
            )
        {
            _this.ifNotNull(a => this.Set(_this: null, _nVirtKey: _this.p_nVirtKey, _Description: _this.p_Description));
            _nVirtKey.ifNotNull(a => this.p_nVirtKey = _nVirtKey.Value);
            _Description.ifNotNull(a => this.p_Description = _Description);
            return this;
        }
        public System.Object ToAnonimus() { return new { nVirtKey = this.p_nVirtKey, Description = this.p_Description }; }
    }
}
