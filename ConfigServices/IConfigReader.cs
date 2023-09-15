namespace ConfigServices
{
    public interface IConfigReader
    {
        /// <summary>
        /// 如果配置找不到，就返回null
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetValue(string name);
    }
}