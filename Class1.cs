    public class Class1
    {
        public void a()
        {
            
        }

        public async void b()
        {

        }

        public async Task c()
        {

        }

        public async Task d()
        {
            await c();
        }

        public async Task<int> e()
        {
            return default(int);
        }

        public async Task<int> f()
        {
            return await e();
        }

        public void g()
        {
            var action = new Action(() => { });
        }

        public void h()
        {
            var action = new Action(async () => { });
        }

        public void i()
        {
            var action = new Action(() => Task.Delay(1000));
        }

        public void j()
        {
            var action = new Action(async () => await Task.Delay(1000));
        }

        public void k()
        {
            var action = new Action(() => Task.Delay(1000));
            action();
        }

        public void l()
        {
            var action = new Action(async () => await Task.Delay(1000));
            action();
        }
    }
