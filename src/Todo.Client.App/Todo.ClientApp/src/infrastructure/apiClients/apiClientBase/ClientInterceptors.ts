import type {AxiosError, AxiosInstance, AxiosResponse} from "axios";
import type {IMappable} from "@/infrastructure/mappers/IMappable";
import {ApiResponse} from "@/infrastructure/apiClients/apiClientBase/ApiResponse";
import type {ProblemDetails} from "@/infrastructure/apiClients/apiClientBase/ProblemDetails";

export class ClientInterceptors {

    public static registerResponseConverter(client: AxiosInstance) {
        client.interceptors.response.use(<TResponse extends IMappable<TResponse>>(response: AxiosResponse<TResponse>) => {
                return {
                    ...response,
                    data: new ApiResponse(response.data as TResponse, null, response.status)
                }
            },
            (error: AxiosError) => {
                return {
                    ...error,
                    data: new ApiResponse(null, error.response?.data as ProblemDetails, error.response?.status ?? 500)
                };
            }
        );
    }
}
