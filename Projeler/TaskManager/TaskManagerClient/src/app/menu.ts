export class MenuModel {
    name: string = "";
    icon: string = "";
    url: string = "";
    isTitle: boolean = false;
    subMenus: MenuModel[] = [];
}

export const Menus: MenuModel[] = [
    {
        name: "Ana Sayfa",
        icon: "far fa fa-home",
        url: "/",
        isTitle: false,
        subMenus: []
    },
    {
        name: "Tasklar",
        icon: "far fa fa-home",
        url: "/tasks",
        isTitle: false,
        subMenus: []
    }
]