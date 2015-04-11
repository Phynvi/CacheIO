﻿using System;

namespace CacheIO.IO
{
	public abstract class DataStream
	{
		/*
		 * Mersenne numbers
		 * for (int i = 0; i < 32; i++) BIT_MASK[i] = (1 << i) - 1;
		 */
		protected static readonly int[] BIT_MASK = { 0, 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095, 8191, 16383, 32767, 65535, 131071, 262143, 524287, 1048575, 2097151, 4194303, 8388607, 16777215, 33554431, 67108863, 134217727, 268435455, 536870911, 1073741823, 2147483647, -1 };

		protected int _offset = 0;
		//protected int bitPosition;

		protected int _length = 0;
		protected byte[] _buffer = null;

		public int getLength()
		{
			return _length;
		}

		public int getRemaining()
		{
			return _offset < _length ? _length - _offset : 0;
		}

		public int getOffset()
		{
			return _offset;
		}

		public void setOffset(int offset)
		{
			_offset = offset;
		}

		public void Skip(int length)
		{
			_offset += length;
		}

		public byte[] getBuffer()
		{
			return _buffer;
		}
	}
}