import { User } from './user';

export interface Like {
    commentId: number;
    appUserId: string;
}

export interface Comment {
    id: number;
    body: string;
    user: User;
    likes: Like[];
}
