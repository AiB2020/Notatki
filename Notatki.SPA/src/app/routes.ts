import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UsereListComponent } from './users/usere-list/usere-list.component';
import { LikesComponent } from './likes/likes.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';
import { UserDetailComponent } from './users/user-detail/user-detail.component';
import { UserDetailResolver } from './_resolvers/user-detail.resolver';
import { UserListResolver } from './_resolvers/user-list.resolver';
import { UserEditComponent } from './users/user-edit/user-edit.component';
import { UserEditResolver } from './_resolvers/user-edit.resolver';
import { PreventUnsavesChanges } from './_guards/prevent-unsaved-changes-guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    { path: '',
      runGuardsAndResolvers: 'always',
      canActivate: [AuthGuard],
      children: [
        { path: 'users', component: UsereListComponent, resolve: {users: UserListResolver}},
        { path: 'users/:id', component: UserDetailComponent, resolve: {user: UserDetailResolver}},
        { path: 'user/edit', component: UserEditComponent,
                                     resolve: {user: UserEditResolver},
                                     canDeactivate: [PreventUnsavesChanges]},

        { path: 'likes', component: LikesComponent},
        { path: 'messages', component: MessagesComponent},
      ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'},
];