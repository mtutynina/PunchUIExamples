import * as ko from "knockout";
import { registerPaginationComponent } from "punch-ui";

class App {}

function bootstrap() {
    registerPaginationComponent();
    const app = new App();
    ko.applyBindings(app);
}

bootstrap();
