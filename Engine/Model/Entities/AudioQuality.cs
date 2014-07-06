﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Model.Entities
{
  [Serializable]
  public class AudioQuality
  {
    public int Channels { get; set; }
    public int Bits { get; set; }
    public int Frequency { get; set; }

    public AudioQuality(int channels, int bits, int frequency)
    {
      if (channels != 2 && channels != 1)
        throw new ArgumentException("channels");

      if (bits != 8 && bits != 16)
        throw new ArgumentException("bitPerChannel");

      if (frequency <= 0)
        throw new ArgumentException("frequency");

      Channels = channels;
      Bits = bits;
      Frequency = frequency;
    }

    public override string ToString()
    {
      return string.Format("{0} бит / {1} Гц", Bits, Frequency);
    }
  }
}
