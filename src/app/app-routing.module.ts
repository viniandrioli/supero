import { NgModule } from '@angular/core';
import { RouterModule, Routes, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { TasklistComponent } from '../components/tasklist/tasklist.component';
import { HomeComponent } from '../components/home/home.component';

const appRoutes: Routes = [
    { path: '', component: HomeComponent },
 
  ];
  
  @NgModule({
    imports: [
      RouterModule.forRoot(
        appRoutes,
        {
          enableTracing: false, // <-- debugging purposes only
          useHash: false
        }
      )
    ],
    providers: [
      {
        provide: 'externalUrlRedirectResolver',
        useValue: (route: ActivatedRouteSnapshot, state: RouterStateSnapshot) => {
          window.location.href = (route.data as any).externalUrl;
        }
      }
    ],
    exports: [
      RouterModule
    ]
  })
  export class AppRoutingModule { }