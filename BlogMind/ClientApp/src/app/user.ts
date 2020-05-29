export interface Address {
    id: number;
    street: string;
    suite: string;
    city: string;
    zipcode: string;
}

export interface User {
    id: string;
    name: string;
    email: string;
    address: Address;
    phoneNumber: string;
}
