﻿// Decompiled with JetBrains decompiler
// Type: midp.ThreadMutex
// Assembly: sims3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7B131356-9960-4428-AE45-C717550C1909
// Assembly location: E:\wamwo\Downloads\The Sims 3 1.0.0.0\sims3.dll

namespace midp
{
  public abstract class ThreadMutex
  {
    public virtual void Dispose()
    {
    }

    public abstract void @lock();

    public abstract void unlock();
  }
}
