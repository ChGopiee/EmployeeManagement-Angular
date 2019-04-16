import { Routes } from "@angular/router";
import { AppComponent } from "./app.component";

export const AppRoutes: Routes = [
  {
    path: 'AppConfiguration', component: AppComponent, pathMatch: 'full'
  },
  { path: '', redirectTo: 'AppConfiguration', pathMatch: 'full' },
  { path: '**', redirectTo: 'AppConfiguration', pathMatch: 'full' }
];
