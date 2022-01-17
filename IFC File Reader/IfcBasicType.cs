using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFC4
{
	public class REAL
	{
		public float Value { get; set; }
		public REAL() { }
		public REAL(float value) { Value = value; }
		public static implicit operator REAL(float x) { return new REAL(x); }
		public static implicit operator float(REAL x) { return x.Value; }
		public override string ToString()
		{
			return Value + "";
		}
	}

	public class INTEGER
	{
		public int Value { get; set; }
		public INTEGER() { }
		public INTEGER(int value) { Value = value; }
		public static implicit operator INTEGER(int x) { return new INTEGER(x); }
		public static implicit operator int(INTEGER x) { return x.Value; }
		public override string ToString()
		{
			return string.Format("Integer({0})", Value);
		}
	}

	public class NUMBER
	{
		public float Value { get; set; }
		public NUMBER() { }
		public NUMBER(float value) { Value = value; }
		public static implicit operator NUMBER(float x) { return new NUMBER(x); }
		public static implicit operator float(NUMBER x) { return x.Value; }
		public override string ToString()
		{
			return Value + "";
		}
	}

	public class LOGICAL
	{
		public bool Value { get; set; }
		public LOGICAL() { }
		public LOGICAL(bool value) { Value = value; }
		public static implicit operator LOGICAL(bool x) { return new LOGICAL(x); }
		public static implicit operator bool(LOGICAL x) { return x.Value; }
		public override string ToString()
		{
			return Value + "";
		}
	}

	public class BOOLEAN
	{
		public bool Value { get; set; }
		public BOOLEAN() { }
		public BOOLEAN(bool value) { Value = value; }
		public static implicit operator BOOLEAN(bool x) { return new BOOLEAN(x); }
		public static implicit operator bool(BOOLEAN x) { return x.Value; }
		public override string ToString()
		{
			return Value + "";
		}
	}

	public class BINARY
	{
		public int Value { get; set; }
		public BINARY() { }
		public BINARY(int value) { Value = value; }
		public static implicit operator BINARY(int x) { return new BINARY(x); }
		public static implicit operator int(BINARY x) { return x.Value; }
		public override string ToString()
		{
			return string.Format("Integer({0})", Value);
		}
	}

	public class STRING
	{
		public string Value { get; set; }
		public STRING() { }
		public STRING(string value) { Value = value; }
		public static implicit operator STRING(string x) { return new STRING(x); }
		public static implicit operator string(STRING x) { return x.Value; }
		public override string ToString()
		{
			return Value;
		}
	}

}
