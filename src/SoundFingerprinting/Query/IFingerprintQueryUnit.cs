﻿namespace SoundFingerprinting.Query
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IFingerprintQueryUnit
    {
        Task<QueryResult> Query();

        Task<QueryResult> Query(CancellationToken cancelationToken);
    }
}