using Microsoft.AspNetCore.Mvc;

namespace ObjektorienteradAnalysOchDesignAssignment.Factories
{
    public class StatusFactory
    {
        public static OkResult CreateOkResult() => new OkResult();
    }
}
