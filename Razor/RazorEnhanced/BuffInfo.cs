using System;

namespace RazorEnhanced
{
    /// <summary>
    /// Contains all buff information
    /// </summary>
    public class BuffInfo
    {
        internal BuffInfo(Assistant.BuffInfo buff)
        {
            Buff = Player.GetBuffDescription(buff.Buff);
            Started = buff.Started;
            Duration = buff.Duration;
        }
        /// <summary>
        /// Buff type
        /// </summary>
        public string Buff { get; }
        /// <summary>
        /// Started datetime useful for remaining calculations
        /// </summary>
        public DateTime Started { get; }
        
        /// <summary>
        /// Total duration
        /// </summary>
        public TimeSpan Duration { get; }
        
        /// <summary>
        /// Buff time remaining 
        /// </summary>
        public TimeSpan Remaining => (Duration - Elapsed);
        
        /// <summary>
        /// if the buff has expired
        /// </summary>
        public bool HasExpired => (Elapsed > Duration);

        /// <summary>
        /// Buff time elapsed
        /// </summary>
        public TimeSpan Elapsed => (DateTime.Now - Started);
    }
}