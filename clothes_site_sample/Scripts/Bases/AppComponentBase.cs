using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace clothes_site_sample.scripts.Bases
{
    /**
     * コンポーネントの基底クラス
     * .razorファイルで @inherits をすることで、自動でInjectされます。
     */
    public class AppComponentBase<T> : ComponentBase where T : ComponentBase
    {
        /**
         * 通信クラスのInject
         */
        [Inject]
        protected HttpClient HttpClient { get; private set; }

        /**
         * Log用のInject
         */
        [Inject]
        protected ILogger<T> Logger { get; private set; }
    }
}