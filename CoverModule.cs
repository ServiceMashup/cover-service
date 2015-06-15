namespace CoverService
{
    using Nancy;

    public class CoverModule : NancyModule
    {
        public CoverModule(ICoverService coverService)
        {
            Get["/{mbid}", true] = async (x, ct) => await coverService.GetCoverUrlsAsync(x.mbid);
        }
    }
}