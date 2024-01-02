import { TodoEndpointsDetails } from "@/infrastructure/apiClients/todoApiClient/brokers/TodoEndpointsDetails";
import ApiClientBase from "@/infrastructure/apiClients/apiClientBase/ApiClientBase";

export class TodoApiClient {
    private readonly client: ApiClientBase;
    public readonly baseUrl: string;

    constructor() {
        this.baseUrl = "https://localhost:7056";

        this.client = new ApiClientBase({
            baseURL: this.baseUrl
        });

        this.todos = new TodoEndpointsDetails(this.client);
    }

    public todos:TodoEndpointsDetails;
}