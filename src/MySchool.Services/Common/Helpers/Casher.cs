﻿using Microsoft.Extensions.Caching.Memory;

using MySchool.Services.Interfaces.Common;

namespace MySchool.Services.Common.Helpers;

public class Casher : ICasher
{
	private IMemoryCache _cache { get; }
	public Casher(IMemoryCache cache)
	{
		_cache = cache;
	}

	public void Place(long key, int value, double seconds)
	{
		_ = _cache.Set(key, value, TimeSpan.FromSeconds(seconds));
	}

	public int? Get(long key)
	{
		return (int)_cache.Get(key);
	}
}
