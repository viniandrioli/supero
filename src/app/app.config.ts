import { environment } from '../environments/environment';

export interface IAppConfig {
  apiEndpoint: string;
  oldWebUrl: string;
  domain: string;
}

export const AppConfig: IAppConfig = {
  apiEndpoint: environment.apiEndpoint,
  oldWebUrl: environment.oldWebUrl,
  domain: environment.domain
};